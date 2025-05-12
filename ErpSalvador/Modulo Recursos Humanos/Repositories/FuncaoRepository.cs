namespace ErpSalvador.Repositories
{
    public class FuncaoRepository : IFuncaoRepository
    {
        private readonly SystemContext _context;

        public FuncaoRepository(SystemContext context)
        { 
            _context = context;                 
        }

        public async Task<Funcao> CreateFuncaoAsync(Funcao funcao) 
        { 
            _context.Funcoes.Add(funcao);
            await _context.SaveChangesAsync();
            return funcao;
        }

        public async Task<Funcao> ReadFuncaoAsync(int id) 
        {
            return await _context.Funcoes.FindAsync(id);        
        }

        public async Task<IEnumerable<Funcao>> ReadAllFuncaoAsync() 
        { 
            return await _context.Funcoes.ToListAsync();            
        }

        public async Task<Funcao> UpdateFuncaoAsync(Funcao funcao) 
        {
            _context.Funcoes.Update(funcao);
            await _context.SaveChangesAsync();
            return funcao;
        }

        public async Task<bool> DeleteFuncaoAsync(int id) 
        {
            Funcao funcaoParaApagar = await _context.Funcoes.FindAsync(id);          
            _context.Funcoes.Remove(funcaoParaApagar);
            return await _context.SaveChangesAsync() > 0;        
        }
    }
}
