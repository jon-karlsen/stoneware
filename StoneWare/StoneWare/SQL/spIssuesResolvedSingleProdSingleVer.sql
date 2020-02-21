/****** Object:  StoredProcedure [dbo].[spIssuesResolvedSingleProdSingleVer]    Script Date: 19.02.2020 21:04:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jon Karlsen
-- Create date: 17/02/2020
-- Description:	This stored procedure returns all issues with status set to “resolved” for a single product of a single version.
-- =============================================
CREATE PROCEDURE [dbo].[spIssuesResolvedSingleProdSingleVer] 
	-- Add the parameters for the stored procedure here
	@ProductId int, 
	@VersionNumberId int,
	@OperatingSystemId int
AS
BEGIN

	-- Validate inputs not NULL
	IF @ProductId IS NULL 
    BEGIN  
        SELECT 'Parameter @ProductId cannot be NULL.'
        RETURN;
    END

	IF @VersionNumberId IS NULL 
    BEGIN  
        SELECT 'Parameter @VersionNumberId cannot be NULL.'
        RETURN;
    END

	IF @OperatingSystemId IS NULL 
    BEGIN  
        SELECT 'Parameter @OperatingSystemId cannot be NULL.'
        RETURN;
    END

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		i.Id,
		i.ProductId,
		p.Name AS ProductName,
		i.OperatingSystemId,
		os.Name AS OperatingSystem,
		i.VersionNumberId,
		vn.Description AS VersionNumber,
		i.StatusId,
		s.Name AS Status,
		i.TimeCreated,
		i.TimeLastUpdated,
		i.Problem,
		i.Resolution
	FROM 
		dbo.Issue i 		
		INNER JOIN dbo.Status s ON i.StatusId = s.Id
		INNER JOIN dbo.VersionNumber vn ON i.VersionNumberId = vn.Id
		INNER JOIN dbo.OperatingSystem os ON i.OperatingSystemId = os.Id
		INNER JOIN dbo.Product p ON i.ProductId = p.Id
	WHERE
		i.StatusId = 2
		AND ProductId = @ProductId
		AND VersionNumberId = @VersionNumberId
		AND OperatingSystemId = @OperatingSystemId
END
GO