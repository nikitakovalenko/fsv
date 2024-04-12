using CommunityToolkit.Mvvm.ComponentModel;
using Fsv.Common.Entities;

namespace Fsv.Maui.App.ViewModels;

internal class VerificationViewModel : ObservableObject, IQueryAttributable
{
    private readonly Verification _verification;

    public VerificationViewModel(Verification verification)
    {
        _verification = verification;
    }

    public string Date => _verification.DateTime.ToLocalTime().ToString();
    public string CustomerName => _verification.Customer.Name;

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        throw new NotImplementedException();
    }
}
