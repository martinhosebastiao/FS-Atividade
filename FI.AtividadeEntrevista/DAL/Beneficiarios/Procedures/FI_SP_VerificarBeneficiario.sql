﻿
CREATE PROC FI_SP_VerificaBeneficiario
	@CPF VARCHAR(14)
AS
BEGIN
	SELECT 1 FROM BENEFICIARIOS WHERE CPF = @CPF
END
