import tkinter as tk
import socket
import threading as thr

def newThread():
    connectionThread = thr.Thread(target=startServer)
    connectionThread.daemon = True
    connectionThread.start()

def startServer():
    listensocket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    port=8000
    maxConnections = 10
    name = socket.gethostname()
    listensocket.bind(('localhost', port))
    listensocket.listen(maxConnections)
    statusText = "Started server at " + name + " on port " + str(port)
    print(statusText)
    c.create_text(680, 585, text=statusText, fill="white")
    while True:
        (cs, address) = listensocket.accept()
        print("Connection address: ", address)
        t = thr.Thread(target = getChoices, args =(cs,))
        t.daemon = True
        t.start()

def prepareForTransmission(cs, response):
    sendData = bytearray()
    sendData.extend(map(ord, response))
    cs.send(sendData)
    print("Sending message:")
    print(sendData)

def getChoices(cs):
    doorLocked = True
    carLocked = True
    haveDoorKey = False
    while True:
        command = cs.recv(1024).decode()
        if(command == 'Examine' or command == 'examine'):
            response = "Specify what you wish to examine."
            prepareForTransmission(cs,response)
        elif(command == "Examine room" or command == "examine room" or command == "Examine Room" or command == "examine Room"):
            response = "In the room you can see a bed, a small desk with few toys on it, a locked door and a small wardrobe with a globe on top of it."
            prepareForTransmission(cs,response)
        elif(command == "Examine wardrobe" or command == "examine wardrobe" or command == "Examine Wardrobe" or command == "examine Wardrobe"):
            response = "The wardrobe is empty."
            prepareForTransmission(cs,response)
        elif(command == "Examine globe" or command == "examine globe" or command == "Examine Globe" or command == "examine Globe"):
            response = "The globe represents planet Earth in small scale."
            prepareForTransmission(cs,response)
        elif(command == "Examine bed" or command == "examine bed" or command == "Examine Bed" or command == "examine Bed"):
            response = "There is a single pillow on the bed. It looks like something is under it..."
            prepareForTransmission(cs,response)
        elif(command == "Move pillow" or command == "move pillow" or command == "Move Pillow" or command == "move Pillow"):
            response = "There is a small *Winding Key* under the pillow."
            prepareForTransmission(cs,response)
        elif(command == "Take Winding Key" or command == "take Winding Key" or command == "Take winding key" or command == "take winding key" or command == "Grab Winding Key" or command == "grab Winding Key" or command == "Grab winding key" or command == "grab Winding Key"):
            response = "You take the +Winding Key+."
            prepareForTransmission(cs,response)
        elif(command == "Examine desk" or command == "examine desk" or command == "Examine Desk" or command == "examine Desk"):
            response = "There are number of toys on the small desk. A toy car, toy cubes and a toy horse."
            prepareForTransmission(cs,response)
        elif(command == "Examine toy cubes" or command == "examine toy cubes" or command == "Examine Toy Cubes" or command == "examine Toy Cubes"):
            response = "There are letters and numbers on Toy Cubes."
            prepareForTransmission(cs,response)
        elif(command == "Take Toy Cubes" or command == "take Toy Cubes" or command == "Take toy cubes" or command == "take toy cubes" or command == "Grab Toy Cubes" or command == "grab Toy Cubes" or command == "Grab toy cubes" or command == "grab toy cubes"):
            response = "You take +Toy Cubes+."
            prepareForTransmission(cs,response)
        elif(command == "Drop toy cubes" or command == "drop toy cubes" or command == "Drop Toy Cubes" or command == "drop Toy Cubes"):
            response = "You drop -Toy Cubes-."
            prepareForTransmission(cs,response)
        elif(command == "Examine toy horse" or command == "examine toy horse" or command == "Examine Toy Horse" or command == "examine Toy Horse"):
            response = "A simple wooden Toy Horse."
            prepareForTransmission(cs,response)
        elif(command == "Take Toy Horse" or command == "take Toy Horse" or command == "Take toy horse" or command == "take toy horse" or command == "Grab Toy Horse" or command == "grab Toy Horse" or command == "Grab toy horse" or command == "grab toy horse"):
            response = "You take +Toy Horse+."
            prepareForTransmission(cs,response)
        elif(command == "Drop toy horse" or command == "drop toy horse" or command == "Drop Toy Horse" or command == "drop Toy Horse"):
            response = "You drop -Toy Horse-."
            prepareForTransmission(cs,response)
        elif(command == "Examine toy car" or command == "examine toy car" or command == "Examine Toy Car" or command == "examine Toy Car"):
            response = "It seems that there is some kind of key inside a toy car. Upon closer inspection, you see that there is a hole for some sort of winding key."
            prepareForTransmission(cs,response)
        elif(command == "Take Toy Car" or command == "take Toy Car" or command == "Take toy car" or command == "take toy car" or command == "Grab Toy Car" or command == "grab Toy Car" or command == "Grab toy car" or command == "grab toy car"):
            response = "You take the +Toy Car+"
            prepareForTransmission(cs,response)
        elif(command == "Use Winding Key On Toy Car" or command == "use Winding Key on Toy Car" or command == "Use winding key On toy car" or command == "use winding key on toy car"):
            response = "You used -Winding Key- on -Toy Car-. The Toy Car opened all doors after winding up. You can now get the key that's inside the Toy Car."
            carLocked = False
            prepareForTransmission(cs,response)
        elif(command == "Take Key" or command == "take Key" or command == "Take key" or command == "take key" or command == "Grab Key" or command == "grab Key" or command == "Grab key" or command == "grab key"):
            if(carLocked): response = "You're unable to take the key, the Toy Car is locked."
            else: 
                response = "You take the +Key+. Upon further inspection, you realize there's a label on the key. It says: 'Door key'."
                haveDoorKey = True
            prepareForTransmission(cs,response)
        elif(command == "Use Key On Door" or command == "use Key on Door" or command == "Use key On door" or command == "use key on door"):
            if(haveDoorKey == True):
                response = "You use the -Door key- on Door. You hear a clicking sound."
                doorLocked = False
            else: response = "You can't use the key you don't have on the door."
            prepareForTransmission(cs,response)
        elif(command == "Open Door" or command == "open Door" or command == "Open door" or command == "open door"):
            if(doorLocked): response = "The door is locked."
            else: response = "You open the door and get out. Congratulations!"
            prepareForTransmission(cs,response)
            doorLocked = True
            carLocked = True
        elif(command == "restart"):
            doorLocked = True
            carLocked = True
            haveDoorKey = False
        elif(command == ""):
            response = "Wrong command."
            prepareForTransmission(cs,response)
        else:
            response = "Wrong command."
            prepareForTransmission(cs,response)



if __name__ == "__main__":
    root = tk.Tk()

    root.title("Zork style game")
    c = tk.Canvas(bg = "#BDBDBD", height= 600, width= 800)
    c.pack()

    menubar = tk.Menu(root)
    filemenu = tk.Menu(menubar, tearoff=0)
    servermenu = tk.Menu(menubar, tearoff=0)
    menubar.add_cascade(label="File", menu=filemenu)
    filemenu.add_command(label="Quit", command=root.quit)
    menubar.add_cascade(label="Server", menu=servermenu)
    servermenu.add_command(label="Start Server", command=newThread)
    root.config(menu=menubar)

    root.mainloop()