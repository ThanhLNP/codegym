USE [StudentManagement]
GO
-- =============================================
-- Author:		ThanhLNP
-- Create date: 2019/10/18
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[sp_DeleteStudent]
	@Id INT
AS
BEGIN
	DECLARE @ErrMsg NVARCHAR(2000), 
		@ErrSev SMALLINT, 
		@ErrSta SMALLINT

	DECLARE @Result INT = 0

	BEGIN TRANSACTION
	BEGIN TRY
		UPDATE dbo.Student SET isDelete = 1 WHERE Id = @Id
		SET @Result = 1
		COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
    ROLLBACK TRANSACTION

	SELECT @ErrMsg = ERROR_MESSAGE(),
		@ErrSev = ERROR_SEVERITY(),
		@ErrSta = ERROR_STATE()

    RAISERROR(@ErrMsg, @ErrSev, @ErrSta)

    END CATCH

	SELECT @Result AS Result
END