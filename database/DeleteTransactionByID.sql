USE [Finances]
GO
/****** Object:  StoredProcedure [dbo].[DeleteTransactionById]    Script Date: 11/25/2019 11:20:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Jett Hays>
-- Create date: <Create Date,,06/26/2020>
-- Description:	<Description,,Deletes a transaction record by transaction ID>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteTransactionById]
	-- Add the parameters for the stored procedure here
	@ID int
AS
BEGIN

	DELETE FROM [dbo].[Transaction]
	WHERE ID = @ID
END
