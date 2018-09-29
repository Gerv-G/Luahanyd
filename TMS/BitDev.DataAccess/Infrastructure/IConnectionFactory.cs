using Npgsql;

namespace BitDev.DataAccess.Infrastructure
{
    public interface IConnectionFactory
    {
        NpgsqlConnection GetConnection();
    }
}
