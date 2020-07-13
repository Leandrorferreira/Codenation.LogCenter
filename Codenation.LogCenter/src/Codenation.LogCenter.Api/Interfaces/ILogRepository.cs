﻿using Codenation.LogCenter.Api.Models;
using System.Collections.Generic;

namespace Codenation.LogCenter.Api.Interfaces
{
    public interface ILogRepository
    {
        IList<Log> Get();
        IList<Log> GetFileds();
        void Register(Log log);
        void Remove(Log log);
        void Update(Log log);
        Log GetById(int id);
        IList<Log> GetByTitle(string title);
        IList<Log> GetByLevel(string level);
        IList<Log> GetByOrigin(string origin);
    }
}
