using FI.AtividadeEntrevista.DML;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAtividadeEntrevista.Models.Validations;

namespace WebAtividadeEntrevista.Models
{
    public class BeneficiarioModel
    {
        public long Id { get; set; }

        public long IdCliente { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        [Required]
        public string Nome { get; set; }

        /// <summary>
        /// CPF
        /// </summary>
        [Required]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "CPF deve conter 14 digitos")]
        [CPFCheckDigitValidator(ErrorMessage = "O CPF informado é inválido")]
        public string CPF { get; set; }



        public Beneficiario GetBeneficiario(long idCliente = 0)
        {
            var beneficiario = new Beneficiario
            {
                Nome = Nome,
                CPF = CPF,
            };

            if (idCliente > 0)
                beneficiario.IdCliente = idCliente;

            return beneficiario;
        }

        public static BeneficiarioModel ConvertToModel(Beneficiario beneficiario)
        {
            var model = new BeneficiarioModel {
                Id = beneficiario.Id,
                CPF = beneficiario.CPF,
                Nome = beneficiario.Nome
            };

            return model;
        }
    }
}