using System.Data;

namespace WebDbClient.DAO
{
    interface IDAO<T>
    {
        DataTable GetAll();
        T GetbyId(int id);
        void DeleteById(int id);
        void Insert(T obj);
        void Update(T obj);
    }
}
