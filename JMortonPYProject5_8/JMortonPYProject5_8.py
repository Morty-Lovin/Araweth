import tkinter as tk
import tkinter.font as tkFont

app = tk.Tk()

app.winfo_toplevel().title("Python Project 5.8")

app.geometry("640x480")

fontStyle = tkFont.Font(family="Affirmative", size=16)

projectLabel = tk.Label(app, text="The system is idle", font=fontStyle)

def systemOn():
    projectLabel.config(text = "System Running")

def systemOff():
    projectLabel.config(text="System Off")

pixelVirtual = tk.PhotoImage(width=1, height=1)

projectLabel.pack(side=tk.TOP)

buttonOn = tk.Button(app, text="System On", image=pixelVirtual, width=200, height=100, compound="c", command=systemOn)
buttonOn.place(x=100, y=400)

buttonOff = tk.Button(app, text="System Off", image=pixelVirtual, width=200, height=100, compound="c", command=systemOff)
buttonOff.place(x=340, y=400)

buttonExit = tk.Button(app, text="EXIT", command=app.quit)
buttonExit.pack(side=tk.BOTTOM)

app.mainloop()