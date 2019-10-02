using System.Security;
using LibGit2Sharp;

namespace GitCommand
{
    public class PushCommand
    {
        public void Execute(string path, string userName, SecureString password, string branchName)
        {
            using (var repo = new Repository(path))
            {
                repo.Network.Push(repo.Branches[branchName], new PushOptions
                {
                    CredentialsProvider = (url, usernameFromUrl, types) => new SecureUsernamePasswordCredentials()
                    {
                        Username = userName,
                        Password = password
                    }
                });
            }
        }
    }
}
