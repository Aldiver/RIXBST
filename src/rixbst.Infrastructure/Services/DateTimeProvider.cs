using rixbst.Application.Common.Interfaces.Services;

namespace rixbst.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}