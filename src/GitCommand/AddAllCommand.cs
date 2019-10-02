using LibGit2Sharp;

namespace GitCommand
{
    public class AddAllCommand
    {
        public void Execute(string path)
        {
            using (var repo = new Repository(path))
            {
                Commands.Stage(repo, "*");
            }
        }
    }
}
