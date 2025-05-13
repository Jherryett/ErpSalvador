
namespace ErpSalvador.Repositories;
public class EnderecoFuncionarioRepository : IEnderecoFuncionarioRepository
{

    private readonly SystemContext _context;

    public EnderecoFuncionarioRepository(SystemContext context) // construtor
    {
        _context = context;
    }


    public async Task<EnderecoFuncionario> CreateEnderecoFuncionarioAsync(EnderecoFuncionario enderecoFuncionarioFinal)
    {
        _context.EnderecoFuncionarios.Add(enderecoFuncionarioFinal);
        await _context.SaveChangesAsync();
        return enderecoFuncionarioFinal;
    }

    public async Task<EnderecoFuncionario> ReadEnderecoFuncionarioAsync(int id)
    {
        return await _context.EnderecoFuncionarios.FindAsync(id);
    }
    
    public async Task <IEnumerable<EnderecoFuncionario>> ReadAllEnderecoFuncionarioAsync()
    {
        return await _context.EnderecoFuncionarios.ToListAsync();
    }

    public async Task<EnderecoFuncionario> UpdateEnderecoFuncionarioAsync(EnderecoFuncionario enderecoFuncionarioFinal)
    {
        _context.EnderecoFuncionarios.Update(enderecoFuncionarioFinal);
        await _context.SaveChangesAsync();
        return enderecoFuncionarioFinal;
    }
    public async Task <bool> DeleteEnderecoFuncionarioAsync(int id)
    {
        EnderecoFuncionario enderecoFuncionarioFinal = await _context.EnderecoFuncionarios.FindAsync(id);
        _context.EnderecoFuncionarios.Remove(enderecoFuncionarioFinal);
        return await _context.SaveChangesAsync() > 0;

    }

};