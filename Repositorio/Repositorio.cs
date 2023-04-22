using Dapper.Contrib.Extensions;
using MySqlConnector;

namespace AcessoMySQL.Repositorio
{
    public class Repositorio<T> where T : class
    {
        private readonly MySqlConnection _connection;

        public Repositorio(MySqlConnection connection)
            => _connection = connection;

        public IEnumerable<T> Get()
        => _connection.GetAll<T>();

        public T Get(int id)
           => _connection.Get<T>(id);

        public void Create(T model)
            => _connection.Insert<T>(model);

        public void Update(T model)
            => _connection.Update<T>(model);

        public void Delete(T model)
            => _connection.Delete<T>(model);

        public void Delete(int id)
        {
            var model = _connection.Get<T>(id);
            _connection.Delete<T>(model);
        }
    }
}