﻿using System;

namespace AbpCompanyName.AbpProjectName.Models.TokenAuth
{
    public class AuthenticateResultModel
    {
        public string AccessToken { get; set; }

        public string EncryptedAccessToken { get; set; }

        public int ExpireInSeconds { get; set; }

        public Guid UserId { get; set; }
    }
}
