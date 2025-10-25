# What is Git?

Git is a tool for distributed software version management. This is a fancy way of saying it enables multiple contributors to work on the same project at the same time. It also provides for the resolution of any conflicts in a (relatively) elegant fashion. 

# The structure of Git

Upstream repository <- Contributor repositories <- Contributor branches

Since Git is "distributed", each contributor has their own individual code repository on their device. These repositories are NOT identical copies. A contributor intermittently "pushes" their work to their remote repository. When their work is ready for production, they create a [pull request](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/proposing-changes-to-your-work-with-pull-requests/creating-a-pull-request) to the upstream repository. If the request is approved, the changes are merged with the upstream code where they become available to the mainstream public.

Each repository has its own "branches" for separation of work. The use of branches is arbitrary and varied. They may be for specific issues, features, or tickets. They may simply be used to easily track changes of each contributor. 

Any repository **only has one branch "checked out" at a time.** If you push updates to the bumblebee branch, you wont affect anyone who is working on the honeybee branch. 

For example: Let's say this ticket is on the [issue tracker:](https://docs.github.com/en/issues/tracking-your-work-with-issues)
`Ticket #12 "BUG: bee wings aren't flapping."` 
1. You create and **checkout** a new "issue-12" branch (`git checkout -b issue-main`)
2. You implement a solution and fix the bee wings. You **add** your changes to the ["staging area."](https://git-scm.com/about/staging-area) (`git add -u`)
3. You **commit** your work to finalize the changes. (`git commit`)
4. You **push** your work to your remote repository. (`git push origin issue-12`)
5. You navigate to the "Pull requests" tab **of your repository** and create a new pull request to the upstream repository. Now, you wait for approval. Pay attention, you may be asked questions.

# Forking the repository

Before you can do anything, you need to make a [GitHub](https://github.com) account. Once you're signed in, head to the [repository index.](https://github.com/zorafly/TAGameOff2025/tree/main#) There's a lot going on here. You need the "fork" button. It's between "watch and star", below the main tabs (Code, Issues, etc.) Click this, then click the green "create fork" button on the next page to get your own repository. 

Now, you need to clone your repository to your system. This may all seem like a lot, but remember you are working with others. It's important that we stay organized. Windows users can try this graphical [GitHub Desktop application.](https://desktop.github.com/download/) From the command line, you can use a [personal access token](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens#using-a-personal-access-token-on-the-command-line) or an [SSH deploy key](https://docs.github.com/en/authentication/connecting-to-github-with-ssh/managing-deploy-keys) *Don't clone with HTTPS! You won't be able to push!*

Finally, you are ready to get started. Move on to [GODOT.md](https://github.com/zorafly/TAGameOff2025/blob/main/GODOT.md) to take your first steps with the Godot Engine.
