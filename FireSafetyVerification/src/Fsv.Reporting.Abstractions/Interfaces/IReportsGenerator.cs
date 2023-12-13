namespace Fsv.Reporting.Abstractions;

public interface IReportsGenerator
{
    ReportGenerationResult GenerateReport(ReportData reportParameters);
}
