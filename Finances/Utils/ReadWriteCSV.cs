
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IBSampleApp.util
{
    /// <summary>
    /// Class to store one CSV row
    /// </summary>
    public class CsvStringRow : List<string>
    {
        public string LineText { get; set; }
    }

    public class CsvDoubleRow : List<double>
    {
        public string LineText { get; set; }
    }

    /// <summary>
    /// Class to write data to a CSV file
    /// </summary>
    public class CsvFileWriter : StreamWriter
    {
        public CsvFileWriter(Stream stream)
            : base(stream)
        {
        }

        public CsvFileWriter(string filename)
            : base(filename)
        {
        }

        /// <summary>
        /// Writes a single row to a CSV file.
        /// </summary>
        /// <param name="stringRow">The row to be written</param>
        public void WriteRow(CsvStringRow stringRow)
        {
            var builder = new StringBuilder();
            var firstColumn = true;
            foreach (var value in stringRow)
            {
                // Add separator if this isn't the first value
                if (!firstColumn)
                    builder.Append(',');
                // Implement special handling for values that contain comma or quote
                // Enclose in quotes and double up any double quotes
                if (value.IndexOfAny(new char[] { '"', ',' }) != -1)
                    builder.AppendFormat("\"{0}\"", value.Replace("\"", "\"\""));
                else
                    builder.Append(value);
                firstColumn = false;
            }
            stringRow.LineText = builder.ToString();
            WriteLine(stringRow.LineText);
        }

        /// <summary>
        /// Writes a single row to a CSV file.
        /// </summary>
        /// <param name="doubleRow">The row to be written</param>
        public void WriteRow(CsvDoubleRow doubleRow)
        {
            var builder = new StringBuilder();
            var firstColumn = true;
            foreach (var value in doubleRow)
            {
                // Add separator if this isn't the first value
                if (!firstColumn)
                    builder.Append(',');

                builder.Append(value);
                firstColumn = false;
            }
            doubleRow.LineText = builder.ToString();
            WriteLine(doubleRow.LineText);
        }

        public void WriteRow(int sequence, DateTime dateTime, CsvDoubleRow doubleRow)
        {
            var builder = new StringBuilder();

            builder.Append(sequence);
            builder.Append(',');
            builder.Append(dateTime.Date);
            builder.Append(',');
            builder.Append(dateTime.TimeOfDay);

            foreach (var value in doubleRow)
            {
                builder.Append(',');
                builder.Append(value);
            }
            doubleRow.LineText = builder.ToString();
            WriteLine(doubleRow.LineText);
        }

    }

    /// <summary>
    /// Class to read data from a CSV file
    /// </summary>
    public class CsvFileReader : StreamReader
    {
        public CsvFileReader(Stream stream)
            : base(stream)
        {
        }

        public CsvFileReader(string filename)
            : base(filename)
        {
        }

        /// <summary>
        /// Reads a row of data from a CSV file
        /// </summary>
        /// <param name="stringRow"></param>
        /// <returns></returns>
        public bool ReadRow(CsvStringRow stringRow)
        {
            stringRow.LineText = ReadLine();
            if (string.IsNullOrEmpty(stringRow.LineText))
                return false;

            var pos = 0;
            var rows = 0;

            while (pos < stringRow.LineText.Length)
            {
                string value;

                // Special handling for quoted field
                if (stringRow.LineText[pos] == '"')
                {
                    // Skip initial quote
                    pos++;

                    // Parse quoted value
                    var start = pos;
                    while (pos < stringRow.LineText.Length)
                    {
                        // Test for quote character
                        if (stringRow.LineText[pos] == '"')
                        {
                            // Found one
                            pos++;

                            // If two quotes together, keep one
                            // Otherwise, indicates end of value
                            if (pos >= stringRow.LineText.Length || stringRow.LineText[pos] != '"')
                            {
                                pos--;
                                break;
                            }
                        }
                        pos++;
                    }
                    value = stringRow.LineText.Substring(start, pos - start);
                    value = value.Replace("\"\"", "\"");
                }
                else
                {
                    // Parse unquoted value
                    var start = pos;
                    while (pos < stringRow.LineText.Length && stringRow.LineText[pos] != ',')
                        pos++;
                    value = stringRow.LineText.Substring(start, pos - start);
                }

                // Add field to list
                if (rows < stringRow.Count)
                    stringRow[rows] = value;
                else
                    stringRow.Add(value);
                rows++;

                // Eat up to and including next comma
                while (pos < stringRow.LineText.Length && stringRow.LineText[pos] != ',')
                    pos++;
                if (pos < stringRow.LineText.Length)
                    pos++;
            }
            // Delete any unused items
            while (stringRow.Count > rows)
                stringRow.RemoveAt(rows);

            // Return true if any columns read
            return (stringRow.Count > 0);
        }
    }
}