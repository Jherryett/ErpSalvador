
namespace ErpSalvador.Repositories;
public class EnderecoFuncionarioRepository : IEnderecoFuncionarioRepository
{

    private readonly SystemContext _context;

    public EnderecoFuncionarioRepository(SystemContext context) // construtor
    {
        _context = context;
    }


    public void CreateEnderecoFuncionario(EnderecoFuncionario enderecoFuncionarioFinal)
    {
        _context.EnderecoFuncionarios.Add(enderecoFuncionarioFinal);
        _context.SaveChanges();
    }

    public EnderecoFuncionario? ReadEnderecoFuncionario(int id)
    {
        return _context.EnderecoFuncionarios.Find(id);
    }
    
    public IEnumerable<EnderecoFuncionario> ReadAllEnderecoFuncionario()
    {
        return _context.EnderecoFuncionarios;
    }

    public bool UpdateEnderecoFuncionario(EnderecoFuncionario enderecoFuncionarioFinal)
    {
        _context.EnderecoFuncionarios.Update(enderecoFuncionarioFinal);
        return _context.SaveChanges() > 0;
    }
    public bool DeleteEnderecoFuncionario(EnderecoFuncionario enderecoFuncionarioFinal)
    {
        _context.EnderecoFuncionarios.Remove(enderecoFuncionarioFinal);
        return _context.SaveChanges() > 0;

    }

};