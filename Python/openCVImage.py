import cv2
ccmsid= "37849621"
def resize():
    # Load the image
    image_path = ccmsid+'.jpg'
    image = cv2.imread(image_path)

    if image is None:
        print('Error: Failed to load image')
        exit(1)

    # Convert the image to grayscale
    gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)

    # Load the face cascade classifier
    face_cascade = cv2.CascadeClassifier(cv2.data.haarcascades + 'haarcascade_frontalface_alt.xml')

    # Detect the faces in the image
    faces = face_cascade.detectMultiScale(gray)

    if len(faces) == 0:
        print('Error: No faces detected')
        exit(1)
    
    # Crop the image for each face and save the cropped image
    for i, (x, y, w, h) in enumerate(faces):
        buffer = 30
        cropped_image = image[y-buffer:y+h+buffer, x-buffer:x+w+buffer]
        cv2.imwrite(ccmsid+'.jpg', cropped_image)
    print('done')
resize()