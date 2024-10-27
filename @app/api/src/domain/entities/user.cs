namespace Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Role { get; private set; }
        public string PasswordHash { get; private set; }

        public Usuario(Guid id, string email, string nombre, string role, string passwordHash)
        {
            Id = id;
            Email = email;
            Nombre = nombre;
            Role = role;
            PasswordHash = passwordHash;
        }
        
        // Cambia la contraseña
        public void ChangePassword(string newPasswordHash)
        {
            PasswordHash = newPasswordHash;
        }
    }
}