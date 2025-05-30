﻿using Backend.Erp.Skeleton.Application.Commands.Authorization;
using FluentValidation;

namespace Backend.Erp.Skeleton.Application.Validators.Authorization
{
    internal class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(x => x.Request)
                .NotNull();
        }
    }
}
