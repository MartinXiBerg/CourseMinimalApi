# Container
- Docker Desktop vs. Podman
- (Dapr.io)[docker pull registry:2]

## Commands für Docker
- [Cheat Sheet](https://docs.docker.com/get-started/docker_cheatsheet.pdf)
- [Web Cheat Sheet](https://www.geeksforgeeks.org/docker-cheat-sheet/)
- [Usage with PowerShell](https://forums.docker.com/t/execute-docker-run-through-powershell-script/86705)
- [Small Tips for Docker with PowerShell](https://thenewandshiny.com/small-tips-for-docker/)
- [Docker File command reference](https://docs.docker.com/reference/dockerfile/#from)

## Docker example on command line
-  docker build -t beer-service:v1.0.0 -f .\BeerStore\Dockerfile 
- docker image ls
- docker container ls
- docker run -p 80:8080 --rm -d --name beer-service beer-service:v1.0.0
- docker container stop e8e838fee584

## Docker Compose
- Um mehrere Images zusammenzufügen
- Docker network [Beschreibung](https://docs.docker.com/engine/network/)
- Aspirate , Aspir8 :.NET Tool für "Docker Compose" [Beschreibung](https://medium.com/@josephsims1/aspire-aspi8-deploy-microservices-effortlessly-with-cli-no-docker-or-yaml-needed-f30b58443107)
- Template YAML file for .NET [.NET samples](https://docs.docker.com/reference/samples/dotnet/)
  - [Beispiel von Awesome-compose](https://github.com/docker/awesome-compose/tree/18f59bdb09ecf520dd5758fbf90dec314baec545/nginx-aspnet-mysql)

## Issue Docker Container mit https
- [Asp.Net-Core Application in docker over https](https://stackoverflow.com/questions/60724704/asp-net-core-application-in-docker-over-https)
- [Windows using Linux containers](https://learn.microsoft.com/en-us/aspnet/core/security/docker-https?view=aspnetcore-3.1)
- [Create a Docker Container with project command **Publish...** ](https://learn.microsoft.com/en-us/azure/container-apps/deploy-visual-studio)

## Kubernetes
- [Kubernetes Event-driven Autoscaling](https://keda.sh/)
- Docker Desktop kann ein Cubernetes Cluster zum Ausprobieren aufsetzen
- Expose an application running in your cluster behind a single outward-facing endpoint [Service](https://kubernetes.io/docs/concepts/services-networking/service/) 
  - Oft verwendet: [Ingress](https://kubernetes.io/docs/concepts/services-networking/ingress/)
  > Ingress controller ist kompliziert zu konfigurieren
