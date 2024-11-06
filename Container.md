# Container
- Docker Desktop vs. Podman

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
