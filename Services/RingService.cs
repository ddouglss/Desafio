using AppTeste.Data;
using AppTeste.Models;


public class RingService {
    private readonly AppTesteContext _context;

    public RingService(AppTesteContext context) {
        _context = context;
    }

    // Validação para o número máximo de anéis de acordo com o portador
    public string ValidarNumeroDeAneis(Ring ring) {
        var existingRings = _context.Ring.Where(r => r.Portador == ring.Portador).ToList();

        if (ring.Portador == "Elfo" && existingRings.Count >= 3)
            return "Elfos podem ter no máximo 3 anéis.";
        if (ring.Portador == "Anão" && existingRings.Count >= 7)
            return "Anões podem ter no máximo 7 anéis.";
        if (ring.Portador == "Homem" && existingRings.Count >= 9)
            return "Homens podem ter no máximo 9 anéis.";
        if (ring.Portador == "Sauron" && existingRings.Count >= 1)
            return "Sauron pode ter apenas 1 anel.";

        return null!; // Nenhum erro
    }
}
