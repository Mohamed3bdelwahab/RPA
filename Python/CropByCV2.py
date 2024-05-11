import cv2
import os

# Load the image
image_path = "image.jpg"

if not os.path.isfile(image_path):
    print("Error: Image file not found")
    exit(1)

image = cv2.imread(image_path)

if image is None:
    print("Error: Failed to load image")
    exit(1)

# Convert to grayscale
gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)

# Initialize the face detector
face_cascade = cv2.CascadeClassifier("haarcascade_frontalface_default.xml")

# Detect the faces in the image
faces = face_cascade.detectMultiScale(gray, scaleFactor=1.3, minNeighbors=5, minSize=(30, 30), flags=cv2.CASCADE_SCALE_IMAGE)

if len(faces) == 0:
    print("Error: No faces detected")
    exit(1)

# Crop the image for each face and save the cropped image
for i, (x, y, w, h) in enumerate(faces):
    cropped_image = image[y:y+h, x:x+w]
    cv2.imwrite("face_{}.jpg".format(i), cropped_image)