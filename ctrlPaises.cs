using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo
{
    internal class ctrlPaises: SysLojaInfo.ctrl
    {
        private daoPaises aDao;

        public ctrlPaises() 
        { 
            aDao = new daoPaises();
        }
        public override void salvar(object obj)
        {
            base.salvar(obj);
            aDao.salvar(obj);
        }
        public override void editar(object obj)
        {
            aDao.editar(obj);
        }

        public override void deletar(object obj)
        {
            aDao.deletar(obj);
        }

        public override DataTable SelecionaDS()
        {
            return aDao.SelecionaDS();
        }
    }
}
