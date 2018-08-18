describe("addition of 2 numbers", () => {
    let model = getModel("");
    it("when 2 positive whole numbers", () => {        
        expect(model.add(6, 7)).toBe(13);
    });
    it("when one number is a negative number and the other is a positive number", () => {
        expect(model.add(6, -2)).toBe(4);
    });
});
