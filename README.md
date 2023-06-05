# andreani-sandbox

# Build

Remind to add "sudo" before docker command if you have root permissions

docker build -t andreani-sandbox-image .

docker run -d -p 5020:80 --name andreani-sandbox-container andreani-sandbox-image