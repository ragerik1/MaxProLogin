using System;
using UnityEngine.Scripting;
using MaxProFitness.Sdk;

namespace maxprofitness.login
{
    /// <summary>
    ///     It is expected to receive a <see cref="TotalRepsClearMaxProCommand"/> as response.
    /// </summary>
    [Preserve]
    [Serializable]
    public struct TotalRepsClearAppCommand : IAppCommand
    {
        public CommandType CommandType => CommandType.TotalRepsClear;

        public bool Deserialize(byte[] data)
        {
            return true;
        }

        public string ToHexData()
        {
            return string.Empty;
        }
    }
}
