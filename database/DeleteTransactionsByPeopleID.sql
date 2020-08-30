USE [Finances]
GO
/****** Object:  StoredProcedure [dbo].[DeleteTransactionsByPeopleID]    Script Date: 11/25/2019 11:20:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Jett Hays>
-- Create date: <Create Date,,06/26/2020>
-- Description:	<Description,,Deletes transaction records by people ID>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteTransactionsByPeopleID]
	-- Add the parameters for the stored procedure here
	@PeopleID int
AS
BEGIN

	DELETE FROM [dbo].[Transaction]
	WHERE PeopleID = @PeopleID
END

