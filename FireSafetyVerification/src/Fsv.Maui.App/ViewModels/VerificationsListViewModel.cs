using Fsv.Common.Bll.Abstractions;
using System.Collections.ObjectModel;

namespace Fsv.Maui.App.ViewModels;

internal class VerificationsListViewModel : IQueryAttributable
{
    private readonly IVerificationsService _verificationsService;

    public VerificationsListViewModel(IVerificationsService verificationsService)
    {
        _verificationsService = verificationsService;

        AllVerifications = new ObservableCollection<VerificationViewModel>(_verificationsService.GetVerifications().Select(n => new VerificationViewModel(n)));
    }

    public ObservableCollection<VerificationViewModel> AllVerifications { get; }


    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        throw new NotImplementedException();
    }
}
