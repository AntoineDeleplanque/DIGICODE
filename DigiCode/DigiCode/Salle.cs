namespace DigiCode
{
    partial class SalleEntity
    {
        public void ResetCode()
        {
            using (var DbModelContainer = new DbModelContainer())
            {
                DbModelContainer.SalleEntityJeu.Find(this.ID).Code = null;
                DbModelContainer.SaveChanges();
            }
        }
    }
}
