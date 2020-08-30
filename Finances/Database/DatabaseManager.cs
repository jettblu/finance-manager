using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;


namespace Finances.Database
{
    public class DatabaseManager
    {
        public DataClasses1DataContext DBContext { get; set; }

        //Construction - default
        public DatabaseManager()
        {
            Initialize();
        }

        private void Initialize()
        {
            DBContext = new DataClasses1DataContext();
        }

        //creates new person
        public People CreatePerson(string firstName, string lastName, string email = "", string phoneNumber = "",
            string mugFilePath = "")
        {
            if (firstName.Length < 1 || lastName.Length < 1)
            {
                Utils.UserMessage("You must enter a 'First and Last' name at a minimum", Globals.MessageTypes.Status);
                return null;
            }

            var person = new People()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNumber = phoneNumber,
                MugFilePath = mugFilePath,
                DateCreated = DateTime.Now
            };

            try
            {
                if (PersonExists(firstName, lastName))
                {
                    Utils.UserMessage("This person is already in the database", Globals.MessageTypes.Status);
                    return null;
                }

                DBContext.Peoples.InsertOnSubmit(person);
                DBContext.SubmitChanges();
                return person;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Transaction CreateTransaction(decimal amount, DateTime dateCreated, TransactionType transactionType, People people, Category category, string note = "")
        {
            try
            {
                if (TransactionExists(amount, transactionType, people, category, note))
                {
                    Utils.UserMessage("This transaction is already in the database", Globals.MessageTypes.Status);
                    return null;
                }

                var Transaction = new Transaction()
                {
                    Amount = amount,
                    Note = note,
                    DateOfTransaction = dateCreated,
                    TransactionTypeName = transactionType.TransactionTypeName,
                    Category = category,
                    Categoryname = category.Name,
                    People = people,
                    TransactionType = transactionType,
                    PeeopleName = people.FirstName
                };

                DBContext.Transactions.InsertOnSubmit(Transaction);
                DBContext.SubmitChanges();
                return Transaction;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //updates person already in database
        public People UpdatePerson(string firstName, string lastName, string email = "", string phoneNumber = "",
            string mugFilePath = "")
        {
            var personToUpdate = GetPerson(firstName, lastName);
            personToUpdate.FirstName = firstName;
            personToUpdate.LastName = lastName;
            personToUpdate.Email = email;
            personToUpdate.PhoneNumber = phoneNumber;
            personToUpdate.MugFilePath = mugFilePath;
            try
            {
                DBContext.SubmitChanges();
                return personToUpdate;
            }
            catch (Exception e)
            {
                return null;
            }
            
        }

        //updates transaction already in database
        public Transaction UpdateTransaction(int Trans_Id, decimal amount, DateTime dateCreated, string note = "")
        {
            var transactionToUpdate = GetTransaction(Trans_Id);
            transactionToUpdate.Amount = amount;
            transactionToUpdate.DateOfTransaction = dateCreated;
            
            transactionToUpdate.Category = transactionToUpdate.Category;
            transactionToUpdate.TransactionType = transactionToUpdate.TransactionType;
            transactionToUpdate.Note = note;

            try
            {
                DBContext.SubmitChanges();
                return transactionToUpdate;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public bool PersonExists(string firstName, string lastName)
        {
            return DBContext.Peoples.Any(r => r.FirstName == firstName && r.LastName == lastName);
        }

        public bool TransactionExists(decimal amount, TransactionType transactionType, People people, Category category, string note = "")
        {
            return DBContext.Transactions.Any(r => r.Amount == amount && r.TransactionTypeName == transactionType.TransactionTypeName && r.PeopleID == people.ID && r.Note == note && r.TransactionTypeID == transactionType.ID && r.PeopleID == people.ID);
        }

        public People GetPerson(string firstName, string lastName)
        {
            try
            {
                var rec = (from r in DBContext.Peoples
                    where r.FirstName == firstName && r.LastName == lastName
                    select r).FirstOrDefault();

                return rec;
            }
            catch (Exception)
            {
                throw;
            }
        }

        
        public IEnumerable<People> GetAllPersons()
        {
            try
            {
                var recs = (from r in DBContext.Peoples
                    where r.FirstName.Length > 1
                    select r);

                return recs;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Category GetCategoryByID(int id)
        {
            try
            {
                var rec = (from r in DBContext.Categories
                    where r.ID == id
                    select r).FirstOrDefault();

                return rec;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public People GetPersonByID(int id)
        {
            try
            {
                var rec = (from r in DBContext.Peoples
                    where r.ID == id
                    select r).FirstOrDefault();

                return rec;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Transaction> GetAllTransactions()
        {
            try
            {
                var recs = (from r in DBContext.Transactions
                    select r);

                return recs;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Transaction GetTransaction(int Id)
        {
            try
            {
                var rec = (from r in DBContext.Transactions
                    where r.ID == Id
                    select r).FirstOrDefault();

                return rec;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Transaction> GetTransactionsByPeople(People peep)
        {
            try
            {
                var recs = (from r in DBContext.Transactions
                    where r.PeopleID == peep.ID
                    select r);

                return recs;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Transaction> GetTransactionsByCategory(Category category)
        {
            try
            {
                var recs = (from r in DBContext.Transactions
                    where r.CategoryID == category.ID
                    select r);

                return recs;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Transaction> GetTransactionsByTransactionType(TransactionType transactionType)
        {
            try
            {
                var recs = (from r in DBContext.Transactions
                    where r.TransactionTypeID == transactionType.ID
                    select r);

                return recs;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<Transaction> GetTransactionsByPersonAndCategory(People peep, Category category)
        {
            try
            {
                var recs = (from r in DBContext.Transactions
                    where r.TransactionTypeID == category.ID && r.PeopleID == peep.ID
                    select r);

                return recs;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<Transaction> GetTransactionsByCategoryAndTransactionType(Category category, TransactionType transactionType)
        {
            try
            {
                var recs = (from r in DBContext.Transactions
                    where r.TransactionTypeID == transactionType.ID && r.CategoryID == category.ID
                    select r);

                return recs;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ClearContextCache()
        {
            try
            {
                // Note:  The stored procedure causes the context to be out of sync (locally), we need to flush it!
                DBContext.GetType().InvokeMember(
                    "ClearCache",
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod,
                    null, DBContext, null);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int DeleteTransactionByID(int transactionId)
        {
            var status = DBContext.DeleteTransactionById(transactionId);
            ClearContextCache();
            return status;
        }
        public int DeleteTransactionsByPeopleID(int peopleId)
        {
            var status = DBContext.DeleteTransactionsByPeopleID(peopleId);
            ClearContextCache();
            return status;
        }

    }
}
