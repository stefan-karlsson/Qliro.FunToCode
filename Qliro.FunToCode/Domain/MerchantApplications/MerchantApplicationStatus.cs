using Intellenum;

namespace Qliro.FunToCode.Domain.MerchantApplications;

[Intellenum<string>]
public partial class MerchantApplicationStatus
{
    public static readonly MerchantApplicationStatus Created, Started;
}