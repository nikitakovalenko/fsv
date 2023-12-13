using Fsv.Common.Entities;

namespace Fsv.Common.Bll.Abstractions;

public interface IVerificationsService
{
    IEnumerable<Verification> GetVerifications();
    Verification GetVerification(long Id);
    Verification CreateVerification();
    void AddVerification(Verification verification);
}
