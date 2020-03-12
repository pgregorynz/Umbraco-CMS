﻿using System;
using Umbraco.Core.Configuration.UmbracoSettings;

namespace Umbraco.Core.Configuration
{
    public abstract class PasswordConfiguration : IPasswordConfiguration
    {
        protected PasswordConfiguration(IPasswordConfiguration configSettings)
        {
            if (configSettings == null)
            {
                throw new ArgumentNullException(nameof(configSettings));
            }

            RequiredLength = configSettings.RequiredLength;
            RequireNonLetterOrDigit = configSettings.RequireNonLetterOrDigit;
            RequireDigit = configSettings.RequireDigit;
            RequireLowercase = configSettings.RequireLowercase;
            RequireUppercase = configSettings.RequireUppercase;
            UseLegacyEncoding = configSettings.UseLegacyEncoding;
            HashAlgorithmType = configSettings.HashAlgorithmType;
            MaxFailedAccessAttemptsBeforeLockout = configSettings.MaxFailedAccessAttemptsBeforeLockout;
        }

        public int RequiredLength { get; }

        public bool RequireNonLetterOrDigit { get; }

        public bool RequireDigit { get; }

        public bool RequireLowercase { get; }

        public bool RequireUppercase { get; }

        public bool UseLegacyEncoding { get; }

        public string HashAlgorithmType { get; }

        public int MaxFailedAccessAttemptsBeforeLockout { get; }
    }
}
