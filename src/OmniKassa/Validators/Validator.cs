﻿// <copyright file="Validator.cs" company="Dirk Lemstra">
// Copyright 2017 Dirk Lemstra (https://github.com/dlemstra/OmniKassa).
// Licensed under the MIT License.
// </copyright>

using System;

namespace OmniKassa
{
    internal abstract class Validator
    {
        protected static void ThrowException(string message)
        {
            throw new InvalidOperationException(message);
        }

        protected static void ThrowException(string message, string expectedValue, string actualValue)
        {
            throw new InvalidOperationException($"{message}{Environment.NewLine}Expected value: {expectedValue}.{Environment.NewLine}Actual value: {actualValue}.");
        }

        protected static void ThrowNullException(string name)
        {
            ThrowException($"The value for {name} should not be null.");
        }
    }
}