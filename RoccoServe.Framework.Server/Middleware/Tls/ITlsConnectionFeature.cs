﻿using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace RoccoServe.Framework.Server.Middleware.Tls
{
    public interface ITlsConnectionFeature
    {
        /// <summary>
        /// Synchronously retrieves the remote endpoint's certificate, if any.
        /// </summary>
        X509Certificate2 RemoteCertificate { get; set; }

        /// <summary>
        /// Asynchronously retrieves the remote endpoint's certificate, if any.
        /// </summary>
        /// <returns></returns>
        Task<X509Certificate2> GetRemoteCertificateAsync(CancellationToken cancellationToken);
    }
}
