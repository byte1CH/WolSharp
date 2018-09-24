using System.Collections.Generic;

namespace Byte1.WolSharp
{
    internal class PhysicalAddressValidationResult
    {
        public bool HasErrors { get; set; }

        public IReadOnlyCollection<string> ValidationErrors { get; set; }
    }
}
