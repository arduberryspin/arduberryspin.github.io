import os

def read_message(input_pipe):
    fd = os.open(input_pipe, os.O_RDONLY)
    message = (
        "I pid [%d] received a message => %s"
        % (os.getpid(), os.read(fd, 22)))
        
    os.close(fd)
    
    return message


if __name__ == '__main__' :
    named_pipe = "my_pipe"

    msg = read_message(named_pipe)
    print msg
    


