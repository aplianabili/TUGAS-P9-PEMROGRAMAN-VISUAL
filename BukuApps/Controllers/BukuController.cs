using System.Collections.Generic;
using BukuApps.Models;

namespace BukuApps.Controllers
{
    public class BukuController
    {
        private readonly BukuRepository _repository;

        public BukuController()
        {
            _repository = new BukuRepository();
        }

        public List<Buku> GetAll()
        {
            return _repository.GetAllBuku();
        }

        public void TambahBuku(Buku buku)
        {
            _repository.InsertBuku(buku);
        }

        public void UpdateBuku(Buku buku)
        {
            _repository.UpdateBuku(buku);
        }

        public void HapusBuku(int id)
        {
            _repository.DeleteBuku(id);
        }
    }
}
