using Fsv.Common.Bll.Abstractions;
using Fsv.Common.Entities;

namespace Fsv.Common.Bll.Services
{
    public class VerificationsStubService : IVerificationsService
    {
        private readonly IList<Verification> _verifications;

        public VerificationsStubService()
        {
            _verifications = new List<Verification>()
            {
                new Verification()
                {
                    Id = 1,
                    Customer = new Customer()
                    {
                        Id = 1,
                        Name = "Foo",
                    },
                    DateTime = DateTime.Now.AddDays(-10),
                },
                new Verification()
                {
                    Id = 2,
                    Customer = new Customer()
                    {
                        Id = 1,
                        Name = "Foo",
                    },
                    DateTime = DateTime.Now.AddDays(-1),
                },
                new Verification()
                {
                    Id = 4,
                    Customer = new Customer()
                    {
                        Id = 2!,
                        Name = "Yes",
                    },
                    DateTime = DateTime.Now.AddDays(-1),
                },
            };
        }

        public void AddVerification(Verification verification)
        {
            _verifications.Add(verification);
        }

        public Verification CreateVerification()
        {
            throw new NotImplementedException();
        }

        public Verification GetVerification(long Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Verification> GetVerifications()
        {
            return _verifications;
        }
    }
}
