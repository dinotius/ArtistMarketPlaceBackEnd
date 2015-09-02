using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lembit.ArtistMarketPlace.InfrastructureInterfaces;

namespace Lembit.ArtistMarketPlance.Infrastructure
{
    public class ConsoleLogger : ILogger
    {
        public void Info(string message)
        {
            Debug.WriteLine(message);
        }

        public void Info(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Info(Exception ex, string message)
        {
            throw new NotImplementedException();
        }

        public void Info(Exception ex, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Error(string message)
        {
            throw new NotImplementedException();
        }

        public void Error(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Error(Exception ex, string message)
        {
            throw new NotImplementedException();
        }

        public void Error(Exception ex, string format, params object[] args)
        {
            throw new NotImplementedException();
        }
    }
}
