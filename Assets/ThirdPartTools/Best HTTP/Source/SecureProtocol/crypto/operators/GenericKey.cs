#if !BESTHTTP_DISABLE_ALTERNATE_SSL && (!UNITY_WEBGL || UNITY_EDITOR)
#pragma warning disable
using System;

using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators
{
    public class GenericKey
    {
        private readonly AlgorithmIdentifier algorithmIdentifier;
        private readonly object representation;

        public GenericKey(object representation)
        {
            this.algorithmIdentifier = null;
            this.representation = representation;
        }

        public GenericKey(AlgorithmIdentifier algorithmIdentifier, byte[] representation)
        {
            this.algorithmIdentifier = algorithmIdentifier;
            this.representation = representation;
        }

        public GenericKey(AlgorithmIdentifier algorithmIdentifier, object representation)
        {
            this.algorithmIdentifier = algorithmIdentifier;
            this.representation = representation;
        }

        public AlgorithmIdentifier AlgorithmIdentifier
        {
            get { return algorithmIdentifier; }
        }

        public object Representation
        {
            get { return representation; }
        }
    }
}
#pragma warning restore
#endif
