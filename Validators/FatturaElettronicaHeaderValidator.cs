﻿using FluentValidation;

namespace FatturaElettronica.Validators
{
    public class FatturaElettronicaHeaderValidator : AbstractValidator<FatturaElettronicaHeader.FatturaElettronicaHeader>
    {
        public FatturaElettronicaHeaderValidator()
        {
            RuleFor(x => x.DatiTrasmissione).SetValidator(new DatiTrasmissioneValidator());
            RuleFor(x => x.CedentePrestatore).SetValidator(new CedentePrestatoreValidator());
            RuleFor(x => x.Rappresentante).SetValidator(new RappresentanteFiscaleValidator());
            RuleFor(x => x.CessionarioCommittente).SetValidator(new CessionarioCommittenteValidator());
        }
    }
}
