using System.Security;

namespace TonorpStandAlone.Core.ViewModel.Base
{
    /// <summary>
    /// An Interface for a class that can provide a secure password
    /// </summary>
    public interface IHavePassword
    {
        /// <summary>
        /// The Secure password
        /// </summary>
        SecureString SecurePassword { get; }
    }
}
