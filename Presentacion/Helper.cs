using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public class Helper1
    {

        public void cargarImagen(PictureBox pbo, string imagen)
        {

            try
            {
                pbo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbo.Load("https://i0.wp.com/impactify.io/wp-content/uploads/2024/05/placeholder-5.png?fit=1200%2C800&ssl=1&w=640");
            }
        }
        public void ocultarColumnas(DataGridView dgv)
        {
            dgv.Columns["Id"].Visible = false;
            dgv.Columns["UrlImagen"].Visible = false;
            dgv.Columns["Precio"].DefaultCellStyle.Format = "N1";

        }
        public void validarF(Label lbl1, Label lbl2, Label lbl3, bool txt = false)
        {
            if (txt) {
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = true;
            }
            else
            {

                lbl1.Visible = false;
                lbl2.Visible = false;
                lbl3.Visible = false;
            }
        }
        public void validarF(Label lbl1, Label lbl2, bool txt = false)
        {
            if (txt)
            {
                lbl1.Visible = true;
                lbl2.Visible = true;
            }
            else
            {

                lbl1.Visible = false;
                lbl2.Visible = false;
            }
        }
        public void validarF(Label lbl1, bool txt = false)
        {
            if (txt)
            {
                lbl1.Visible = true;
            }
            else
            {

                lbl1.Visible = false;
            }
        }
        public bool validarNumero(string validar)
        {

            foreach (char caracter in validar)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;

        }
    }
}
