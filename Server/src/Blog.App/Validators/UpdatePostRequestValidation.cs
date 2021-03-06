﻿using FluentValidation;
using Medium.Core.Contracts.V1.Request.Post;

namespace Medium.App.Validators
{
    public class UpdatePostRequestValidation : AbstractValidator<UpdatePostRequest>
    {
        public UpdatePostRequestValidation()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .MaximumLength(50);
        }
    }
}
