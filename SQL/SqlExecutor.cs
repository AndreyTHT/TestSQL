using Npgsql;
using System.Data;

namespace SQL
{
    public class SqlExecutor
    {
        private readonly NpgsqlDataSource db;

        public SqlExecutor()
        {
            db = NpgsqlDataSource.Create(
             "Host=localhost;" +
             "Port=5432;" +
             "Database=shopdb;" +
             "Username=postgres;" +
             "Password=admin");
        }

        // Возвращает число - например, количество строк по заданному условию
        public async Task<int> GetScalarAsync(string sql, params object[] parameters)
        {
            await using NpgsqlCommand command = db.CreateCommand(sql);

            foreach (object parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter);
            }

            object? result = await command.ExecuteScalarAsync();

            return Convert.ToInt32(result);
        }

        // Выполнение SQL команды без ответа (возвращает число - количество затронутых строк) - например запись новой строки
        public async Task<int> ExecuteAsync(string sql, params object[] parameters)
        {
            await using NpgsqlCommand command = db.CreateCommand(sql);

            foreach (object parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter);
            }

            return await command.ExecuteNonQueryAsync();
        }

        // Выполнение SQL команды с ответом (возвращает DataTable) - например вывод строк
        public async Task<DataTable> SelectAsync(string sql, params object[] parameters)
        {
            await using NpgsqlCommand command = db.CreateCommand(sql);

            foreach (object parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter);
            }

            await using NpgsqlDataReader reader =
                await command.ExecuteReaderAsync();

            DataTable table = new DataTable();
            table.Load(reader);

            return table;
        }
    }
}
