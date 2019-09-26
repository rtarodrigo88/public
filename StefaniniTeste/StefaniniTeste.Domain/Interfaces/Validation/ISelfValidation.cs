﻿using StefaniniTeste.Domain.Validation;

namespace StefaniniTeste.Domain.Interfaces.Validation
{
    public interface ISelfValidation
    {
        ValidationResult ValidationResult { get; }
        bool IsValid { get; }
    }
}
