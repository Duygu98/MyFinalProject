using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Temel viodler için balangıç
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }

    }
}
