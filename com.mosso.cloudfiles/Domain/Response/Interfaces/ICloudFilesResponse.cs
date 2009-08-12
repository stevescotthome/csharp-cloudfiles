using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mime;

namespace com.mosso.cloudfiles.domain.response.Interfaces
{
    public interface ICloudFilesResponse:IResponse
    {
        void Close();


        /// <summary>
        /// dictionary of meta tags assigned to this storage item
        /// </summary>
        Dictionary<string, string> Metadata { get; }

        string Method { get;  }
        HttpStatusCode StatusCode { get; }
        string StatusDescription { get;  }
        IList<string> ContentBody { get; }
        string ContentType{ get; }
        string ETag { get; set; }
        Stream GetResponseStream();
        void Dispose();
    }
}