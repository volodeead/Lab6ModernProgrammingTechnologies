using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel; // Потрібно для WCF атрибутів

namespace Lab6Interfaces
{
    [ServiceContract] // WCF сервісний контракт
    public interface IDirectoryService
    {
        [OperationContract] // Операція, доступна через WCF
        List<string> GetDirectories(string path);
    }
}

