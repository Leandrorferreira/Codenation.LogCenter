﻿using Registone.LogCenter.Domain.DataTransferObjects;
using Registone.LogCenter.Domain.Exceptions;
using Registone.LogCenter.Domain.Interfaces;
using Registone.LogCenter.Domain.Models;

namespace Registone.LogCenter.Api.Services
{
    public class UserService : IUserService
    {
        #region Properties
        private IUserRepository Repository { get; set; }

        #endregion

        #region Constructor
        public UserService(IUserRepository repository)
        {
            Repository = repository;
        }

        #endregion

        #region Methods

        public UserAuthenticatedDto Authenticate(UserDto user, byte[] key)
        {
            var userRegister = new User
            {
                Email = user.Email,
                Password = user.Password
            };

            var result = Repository.Login(userRegister);

            if (result is null) throw new UserNotFoundException();
      
            return new UserAuthenticatedDto
            {
                Token = TokenService.GenerateToken(result, key),
                UserEmail = user.Email
            }; ;
        }

        public void Register(UserDto user)
        {
            var userRegister = new User
            {
                Email = user.Email,
                Password = user.Password
            };

            Repository.Register(userRegister);
        }
        
        #endregion
    }
}
