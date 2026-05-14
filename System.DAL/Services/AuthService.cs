using HZY.Framework.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Model.Entity;
using System.Text;

namespace System.DAL
{
    public class AuthService: BaseService<AuthEntity>, IScopedSelfDependency
    {
    }
}
