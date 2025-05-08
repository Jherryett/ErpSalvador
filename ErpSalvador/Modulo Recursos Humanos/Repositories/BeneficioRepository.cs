namespace ErpSalvador.Repositories
{
    public class BeneficioRepository : IBeneficioRepository
    {
        private readonly SystemContext _context;

        public BeneficioRepository(SystemContext context)
        { 
            _context = context;                 
        }

        public async Task CreateBeneficioAsync(Beneficio beneficioFinal) 
        { 
            _context.Beneficios.Add(beneficioFinal);
            await _context.SaveChangesAsync();                    
        }

        public async Task<Beneficio> ReadBeneficioAsync(int id) 
        {
            return await _context.Beneficios.FindAsync(id);        
        }

        public async Task<IEnumerable<Beneficio>> ReadAllBeneficioAsync() 
        { 
            return await _context.Beneficios.ToListAsync();            
        }

        public async Task<bool> UpdateBeneficioAsync(Beneficio beneficio) 
        { 
            _context.Beneficios.Update(beneficio);
            return await _context.SaveChangesAsync() > 0;        
        }

        public async Task<bool> DeleteBeneficioAsync(int id) 
        {
            Beneficio beneficioParaApagar = await _context.Beneficios.FindAsync(id);          
            _context.Beneficios.Remove(beneficioParaApagar);
            return await _context.SaveChangesAsync() > 0;        
        }



























    }
}
