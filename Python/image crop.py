import face_recognition
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

# Find the faces in the image
face_locations = face_recognition.face_locations(image)

if len(face_locations) == 0:
    print("Error: No faces detected")
    exit(1)

# Crop the image for the first detected face and save the cropped image
top, right, bottom, left = face_locations[0]
buffer = 50
cropped_image = image[top-buffer:bottom+buffer, left-buffer:right+buffer]
cv2.imwrite("3769246.jpg", cropped_image)
