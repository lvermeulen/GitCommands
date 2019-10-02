using System;
using LibGit2Sharp;

namespace GitCommand
{
    public class CommitCommand
    {
        public void Execute(string path, string userName, string email, string commitMessage)
        {
            using (var repo = new Repository(path))
            {
                // create committer's signature
                var author = new Signature(userName, email, DateTime.Now);
                var committer = author;

                // commit to repository
                repo.Commit(commitMessage, author, committer);
            }
        }
    }
}
