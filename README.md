# andreani-sandbox


BUILD

docker build -t andreani-sandbox-image .

sudo docker run -d -p 5020:80 --name andreani-sandbox-container andreani-sandbox-image
