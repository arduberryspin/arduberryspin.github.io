import os

def write_message(input_pipe, message):
    fd = os.open(input_pipe, os.O_WRONLY)
    s = "%s from pid [%d]" %(message, os.getpid())
    os.write(fd, (s)) 
    os.close(fd)


if __name__ == '__main__' :
    named_pipe = "my_pipe"
    if not os.path.exists(named_pipe):
        os.mkfifo(named_pipe)

    write_message(named_pipe, 'hello')



